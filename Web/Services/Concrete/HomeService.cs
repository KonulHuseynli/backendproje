using DataAccess.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Web.Services.Abstract;
using Web.ViewModels.Home;

namespace Web.Services.Concrete
{
    public class HomeService : IHomeService
    {
        private readonly IHomeAnimationRepository _homeAnimationRepository;

        public HomeService(IHomeAnimationRepository homeAnimationRepository)
        {
            _homeAnimationRepository = homeAnimationRepository;
        }

        public async Task<HomeIndexVM> GetAllAsync()
        {
            var model = new HomeIndexVM
            {

                homeAnimation = await _homeAnimationRepository.GetAsync(),
            };
            return model;

        }
    }
}
