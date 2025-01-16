

using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace SelfPortalAPi.UnitOfWork
{
    public interface IIndividualRepository
    {
        ReturnObject Login(TokenRequest pObjUser);
    }
    public class IndividualRepository : IIndividualRepository
    {
        //private readonly ApiDbContext _db;
        private readonly SelfServiceConnect _con;
        private readonly IConfiguration _conFig;
        public IndividualRepository(SelfServiceConnect con, IConfiguration conFig)
        {
            //_db = db;
            _con = con;
            // _context = context;
            _conFig = conFig;
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
                    var ret = _con.AdminUsers.FirstOrDefault(o => (o.Username.ToLower().Trim() == pObjUser.PhoneNumber_RIN.ToLower().Trim() || o.Email.ToLower().Trim() == pObjUser.PhoneNumber_RIN.ToLower().Trim()));
                    if (ret == null)
                    {
                        mObjFuncResponse.status = false;
                        mObjFuncResponse.message = "Incorrect Login Credentials";
                    }
                    if (ret.RoleId != 1)
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
            new Claim("TaxpayerTypeId", $"0"),
            new Claim("TaxOffice", $"{ret.TaxOfficeName}"),
            new Claim("UserId", $"Admin-{ret.AdminUserId}"),
            new Claim("IsAdmin", $"yes"),
            new Claim("SuperAdmin", $"{ret.RoleId}")
        }; var aud = "https://your-service.com/api";
                            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);


                            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                                _conFig.GetSection("JWT:Secret").Value));
                            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                            var tokeOptions = new JwtSecurityToken(issuer: str,
                           audience: aud,
                             claims: newclaims,
                              expires: DateTime.UtcNow.AddDays(2),
                              signingCredentials: signinCredentials);
                            var token = new JwtSecurityTokenHandler().WriteToken(tokeOptions);

                            if (!string.IsNullOrEmpty(token))
                            {
                                mObjFuncResponse.data = new
                                { token = token, expiryAt = DateTime.UtcNow.AddDays(1), companyId = ret.AdminUserId, comanyRin = ret.Username, name = ret.ContactName, email = ret.Email, phoneNumber = ret.Phone, TaxpayerTypeId = ret.AdminUserTypeName, isAdminUser = true };
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
                else if (pObjUser.UserType.ToLower() == "super admin")
                {
                    var ret = _con.AdminUsers.FirstOrDefault(o => (o.Username.ToLower().Trim() == pObjUser.PhoneNumber_RIN.ToLower().Trim() || o.Email.ToLower().Trim() == pObjUser.PhoneNumber_RIN.ToLower().Trim()));
                    if (ret == null)
                    {
                        mObjFuncResponse.status = false;
                        mObjFuncResponse.message = "Incorrect Login Credentials";
                    }
                    if (ret.RoleId != 2)
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
            new Claim("TaxpayerTypeId", $"0"),
            new Claim("TaxOffice", $"{ret.TaxOfficeName}"),
            new Claim("UserId", $"Admin-{ret.AdminUserId}"),
            new Claim("IsAdmin", $"yes"),
            new Claim("SuperAdmin", $"{ret.RoleId}")
        }; var aud = "https://your-service.com/api";
                            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);


                            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                                _conFig.GetSection("JWT:Secret").Value));
                            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                            var tokeOptions = new JwtSecurityToken(issuer: str,
                           audience: aud,
                             claims: newclaims,
                              expires: DateTime.UtcNow.AddDays(2),
                              signingCredentials: signinCredentials);
                            var token = new JwtSecurityTokenHandler().WriteToken(tokeOptions);

                            if (!string.IsNullOrEmpty(token))
                            {
                                mObjFuncResponse.data = new
                                { token = token, expiryAt = DateTime.UtcNow.AddDays(1), companyId = ret.AdminUserId, comanyRin = ret.Username, name = ret.ContactName, email = ret.Email, phoneNumber = ret.Phone, TaxpayerTypeId = ret.AdminUserTypeName, isAdminUser = true };
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
                else if (pObjUser.UserType.ToLower() == "assessment officer")
                {
                    var ret = _con.AdminUsers.FirstOrDefault(o => (o.Username.ToLower().Trim() == pObjUser.PhoneNumber_RIN.ToLower().Trim() || o.Email.ToLower().Trim() == pObjUser.PhoneNumber_RIN.ToLower().Trim()));
                    if (ret == null)
                    {
                        mObjFuncResponse.status = false;
                        mObjFuncResponse.message = "Incorrect Login Credentials";
                    }
                    if (ret.RoleId != 3)
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
            new Claim("TaxpayerTypeId", $"0"),
            new Claim("TaxOffice", $"{ret.TaxOfficeName}"),
            new Claim("UserId", $"Admin-{ret.AdminUserId}"),
            new Claim("IsAdmin", $"yes"),
            new Claim("SuperAdmin", $"{ret.RoleId}")
        }; var aud = "https://your-service.com/api";
                            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);


                            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                                _conFig.GetSection("JWT:Secret").Value));
                            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                            var tokeOptions = new JwtSecurityToken(issuer: str,
                           audience: aud,
                             claims: newclaims,
                              expires: DateTime.UtcNow.AddDays(2),
                              signingCredentials: signinCredentials);
                            var token = new JwtSecurityTokenHandler().WriteToken(tokeOptions);

                            if (!string.IsNullOrEmpty(token))
                            {
                                mObjFuncResponse.data = new
                                { token = token, expiryAt = DateTime.UtcNow.AddDays(1), companyId = ret.AdminUserId, comanyRin = ret.Username, name = ret.ContactName, email = ret.Email, phoneNumber = ret.Phone, TaxpayerTypeId = ret.AdminUserTypeName, isAdminUser = true };
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
            new Claim("TaxpayerTypeId", $"{ret.TaxpayerTypeId}"),
            new Claim("TaxOffice", $"{ret.CompanyRin}"),
            new Claim("CompanyId", $"{ret.CompanyId}"),
            new Claim("UserId", $"User-{ret.Id}"),
            new Claim("IsAdmin", $"No"),
            new Claim("SuperAdmin", $"No")
        }; var aud = "https://your-service.com/api";
                                    System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);


                                    var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                                        _conFig.GetSection("JWT:Secret").Value));
                                    var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                                    var tokeOptions = new JwtSecurityToken(issuer: str,
                                   audience: aud,
                                     claims: newclaims,
                                      expires: DateTime.UtcNow.AddDays(2),
                                      signingCredentials: signinCredentials);
                                    var token = new JwtSecurityTokenHandler().WriteToken(tokeOptions);

                                    if (!string.IsNullOrEmpty(token))
                                    {
                                        var bussRins = _con.AssetTaxPayerDetailsApis.Where(o => o.TaxPayerRinnumber == ret.CompanyRin).Select(o => new { id = o.AssetId, name = o.AssetName, rin = o.AssetRin }).ToList();
                                        mObjFuncResponse.data = new
                                        { token = token, expiryAt = DateTime.UtcNow.AddDays(1), phoneNumber = ret.PhoneNumber, companyId = ret.CompanyId, comanyRin = ret.CompanyRin, name = ret.CompanyName, email = ret.Email, TaxpayerTypeId = ret.TaxpayerTypeId, businessRins = bussRins };
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
