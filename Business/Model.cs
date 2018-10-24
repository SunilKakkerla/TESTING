using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Business
{
    public class Model
    {
        public ApplicantModel ConvertToApplicantModel(Models.Applicant app)
        {
            ApplicantModel application = new ApplicantModel()
            {
                Id = app.ApplicantId,
                FirstName = app.FirstName,
                LastName = app.LastName,
                PhoneNumber = app.PhoneNumber,
                Adhar = app.Adhar,
                GenderName = app.GenderName.ToString(),
                NationalityName = app.NationalityName.ToString(),
                Village = app.Address.Village,
                Mandal = app.Address.Mandal,
                District = app.Address.District,
                State = app.Address.State,
                PinCode = app.Address.PinCode


            };
            return application;
        }
    }
}
