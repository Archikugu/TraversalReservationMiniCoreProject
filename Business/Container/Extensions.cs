using Business.Abstract;
using Business.Abstract.AbstractUnitOfWork;
using Business.Concrete;
using Business.Concrete.ConcreteUnitOfWork;
using Business.ValidationRules;
using Business.ValidationRules.ContactUsValidationRules;
using DataAccess.Abstract;
using DataAccess.EntityFramework;
using DataAccess.UnitOfWork;
using DTO.DTOs.AnnouncementDTOs;
using DTO.DTOs.ContactDTOs;
using Entity.Concrete;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfCommentDal>();

            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IDestinationDal, EfDestinationDal>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();

            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<IReservationDal, EfReservationDal>();

            services.AddScoped<IGuideService, GuideManager>();
            services.AddScoped<IGuideDal, EfGuideDal>();

            services.AddScoped<IExcelService, ExcelManager>();

            services.AddScoped<IPdfReportsService, PdfReportManager>();

            services.AddScoped<IContactUsService, ContactUsManager>();
            services.AddScoped<IContactUsDal, EfContactUsDal>();

            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();

            services.AddScoped<IAccountService, AccountManager>();
            services.AddScoped<IAccountDal, EfAccountDal>();

            services.AddScoped<IUnitOfWorkDal, UnitOfWorkDal>();

        }

        public static void CustomValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AnnouncementAddDto>, AnnouncementValidator>();
            services.AddTransient<IValidator<SendMessageDTO>, SendContactUsValidator>();
        }
    }
}
