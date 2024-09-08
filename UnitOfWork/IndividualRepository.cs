

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SelfPortalAPi.Model;
using SelfPortalAPi.Models;
using SelfPortalAPi.NewModel;
using static SelfPortalAPi.AllFunction;
using Exception = System.Exception;
using Individual = SelfPortalAPi.Model.Individual;

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
        private readonly SelfServiceConnect _con;
        private readonly IConfiguration _conFig;
        public IndividualRepository(ApiDbContext db, SelfServiceConnect con,IConfiguration conFig)
        {
            _db = db;
            _con = con;
           // _context = context;
            _conFig = conFig;
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
            catch (System.Exception ex)
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
                if (pObjUser.UserType.ToLower() == "admin")
                {
                    var ret = _con.AdminUsers.FirstOrDefault(o => (o.Phone == pObjUser.PhoneNumber_RIN.ToString().Trim()));
                    if (ret == null)
                    {
                        mObjFuncResponse.status = false;
                        mObjFuncResponse.message = "Incorrect Login Credentials";
                    }
                    else
                    {
                        var str = JsonConvert.SerializeObject(ret);

                        if (BCrypt.Net.BCrypt.Verify(pObjUser.Password, ret.Password))
                        {
                            var newclaims = new[]
    {
            new Claim("TaxpayerTypeId", $"{ret.ContactName}")
        }; var aud = "https://your-service.com/api";
                            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);


                            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                                _conFig.GetSection("JWT:Secret").Value));
                            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                            var tokeOptions = new JwtSecurityToken(issuer: str,
                           audience: aud,
                             claims: newclaims,
                              expires: DateTime.Now.AddDays(2),
                              signingCredentials: signinCredentials);
                            var token = new JwtSecurityTokenHandler().WriteToken(tokeOptions);

                            if (!string.IsNullOrEmpty(token))
                            {
                                mObjFuncResponse.data = new
                                { token = token, expiryAt = DateTime.Now.AddDays(1), companyId = ret.AdminUserId, comanyRin = ret.Username, name = ret.ContactName, email = ret.Email, TaxpayerTypeId = ret.AdminUserTypeName };
                            }
                            else
                            {
                                var response = new ReturnObject { status = false, message = "An Error Occured Generating Token" };
                                return response;
                            }
                        }
                        else
                        {
                            mObjFuncResponse.status = false;
                            mObjFuncResponse.message = "Incorrect Login Credentials";
                        }

                    }
                }
                else
                {
                    var ret = _con.UserManagements.FirstOrDefault(o => (o.CompanyRin == pObjUser.PhoneNumber_RIN.ToString().Trim()) || (o.PhoneNumber == pObjUser.PhoneNumber_RIN.ToString().Trim()));
                    if (ret == null)
                    {
                        mObjFuncResponse.status = false;
                        mObjFuncResponse.message = "Incorrect Login Credentials";
                    }
                    else
                    {
                        var str = JsonConvert.SerializeObject(ret);
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
                                    var newclaims = new[]
            {
            new Claim("TaxpayerTypeId", $"{ret.TaxpayerTypeId}")
        }; var aud = "https://your-service.com/api";
                                    System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);


                                    var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                                        _conFig.GetSection("JWT:Secret").Value));
                                    var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                                    var tokeOptions = new JwtSecurityToken(issuer: str,
                                   audience: aud,
                                     claims: newclaims,
                                      expires: DateTime.Now.AddDays(2),
                                      signingCredentials: signinCredentials);
                                    var token = new JwtSecurityTokenHandler().WriteToken(tokeOptions);

                                    if (!string.IsNullOrEmpty(token))
                                    {
                                        mObjFuncResponse.data = new
                                        { token = token, expiryAt = DateTime.Now.AddDays(1), companyId = ret.Id, comanyRin = ret.CompanyRin, name = ret.CompanyName, email = ret.Email, TaxpayerTypeId = ret.TaxpayerTypeId };
                                    }
                                    else
                                    {
                                        var response = new ReturnObject { status = false, message = "AnError Occured Generating Token" };
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
                }
                return mObjFuncResponse;
            }
            catch (System.Exception ex)
            {
                mObjFuncResponse.message = ex.Message;
                mObjFuncResponse.status = false;
                return mObjFuncResponse;
            }
        }
    }
}
