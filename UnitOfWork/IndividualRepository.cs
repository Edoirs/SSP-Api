

using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using SelfPortalAPi.ErasModel;
using SelfPortalAPi.Model;
using static SelfPortalAPi.AllFunction;

namespace SelfPortalAPi.UnitOfWork
{
    public interface IIndividualRepository
    {
        ReturnObject AddAsycn(IndividualViewModel pObjIndividualModel, int userId);
        ReturnObject Login(TokenRequest pObjUser);
    }
    public class IndividualRepository : IIndividualRepository
    {
        private readonly ApiDbContext _db;
        private readonly ErasContext _context;

        public IndividualRepository(ApiDbContext db, ErasContext context)
        {
            _db = db;
            _context = context;
        }

        public ReturnObject AddAsycn(IndividualViewModel pObjIndividualModel, int userId)
        {

            ReturnObject ret = new();
            try
            {
                if (userId == 0)
                {
                    return new ReturnObject { message = "invalid token", status = false };
                }
                Individual mObjIndividual = new Individual()
                {
                    GenderId = pObjIndividualModel.GenderID,
                    TitleId = pObjIndividualModel.TitleID,
                    FirstName = pObjIndividualModel.FirstName.Trim(),
                    LastName = pObjIndividualModel.LastName.Trim(),
                    MiddleName = pObjIndividualModel.MiddleName,
                    Dob = pObjIndividualModel.DOB,
                    Tin = pObjIndividualModel.TIN,
                    Nin = pObjIndividualModel.NIN,
                    MobileNumber1 = pObjIndividualModel.MobileNumber1,
                    MobileNumber2 = pObjIndividualModel.MobileNumber2,
                    EmailAddress1 = pObjIndividualModel.EmailAddress1,
                    EmailAddress2 = pObjIndividualModel.EmailAddress2,
                    BiometricDetails = pObjIndividualModel.BiometricDetails,
                    TaxOfficeId = pObjIndividualModel.TaxOfficeID,
                    MaritalStatusId = pObjIndividualModel.MaritalStatusID,
                    NationalityId = pObjIndividualModel.NationalityID,
                    TaxPayerTypeId = (int)TaxPayerTypeEnum.Individual,
                    EconomicActivitiesId = pObjIndividualModel.EconomicActivitiesID,
                    NotificationMethodId = pObjIndividualModel.NotificationMethodID,
                    ContactAddress = pObjIndividualModel.ContactAddress,
                    Active = true,
                    CreatedBy = userId,
                    CreatedDate = DateTime.UtcNow
                };
                _db.Individuals.Add(mObjIndividual);
                int rety = _db.SaveChanges();
                if (rety <= 0)
                {
                    return new ReturnObject { message = "an error occur saving individual", status = false };
                }
                return new ReturnObject { status = true, message = "individual added successfully" };
            }
            catch (Exception ex)
            {
                AllFunction.SendErrorToText(ex);
                ret.status = false;
                ret.message = ex.Message;
                return new ReturnObject { message = "an error occur saving individual", status = false };
            }
        }

        public ReturnObject Login(TokenRequest pObjUser)
        {
            int det = 2;
            string firstTImePassword = "p@ssword1";
            if (pObjUser.Password.ToLower().Trim() == firstTImePassword)
                det = 1;
            var mObjFuncResponse = new ReturnObject();
            mObjFuncResponse.status = true;
            mObjFuncResponse.message = "Login Successfully";
            try
            {
                var ret = _db.Companies.FirstOrDefault(o => (o.CompanyRin == pObjUser.PhoneNumber_RIN.ToString().Trim()) || (o.MobileNumber1 == pObjUser.PhoneNumber_RIN.ToString().Trim()) || (o.MobileNumber2 == pObjUser.PhoneNumber_RIN.ToString().Trim()));

                if (ret == null)
                {
                    mObjFuncResponse.status = false;
                    mObjFuncResponse.message = "Incorrect Login Credentials";
                }
                else
                {
                    switch (det)
                    {
                        case 1:
                            if (BCrypt.Net.BCrypt.Verify(pObjUser.Password.ToLower().Trim(), firstTImePassword))
                            {
                                mObjFuncResponse.data = new { isFirstTimer = true };
                            }
                            break;
                        case 2:
                            if (BCrypt.Net.BCrypt.Verify(pObjUser.Password, ret.Password))
                            {
                                var token = AllFunction.GetAccessToken(pObjUser.PhoneNumber_RIN, ret.Password);
                                if (!string.IsNullOrEmpty(token))
                                {
                                    // var user = vFind.FirstOrDefault();
                                    var requestObj1 = new MstUserToken() { CreatedBy = ret.CompanyId, CreatedDate = DateTime.Now, UserId = ret.CompanyId, Token = token, TokenExpiresDate = DateTime.Now.AddDays(1), TokenIssuedDate = DateTime.Now };
                                    _context.MstUserTokens.Add(requestObj1);
                                    _context.SaveChanges();
                                    mObjFuncResponse.data = new { token = token, expiryAt = DateTime.Now.AddDays(1), companyId = ret.CompanyId, name = ret.CompanyName, email = ret.EmailAddress1 };
                                }
                                else
                                {
                                    var response = new ReturnObject { status = false, message ="AnError Occured Generating Token" };
                                    return response;
                                }
                            }
                            else
                            {
                                mObjFuncResponse.status = false;
                                mObjFuncResponse.message = "Incorrect Login Credentials";
                            }
                            break;
                        default:
                            break;
                    }
                }
                return mObjFuncResponse;
            }
            catch (Exception ex)
            {
                mObjFuncResponse.message = ex.Message;
                mObjFuncResponse.status = false;
                return mObjFuncResponse;
            }
        }
    }
}
