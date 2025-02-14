using BlogProject.Domain.Repositories;
using BlogProject.Infrastructure.DataContext;
using GenericRepository;

namespace BlogProject.Infrastructure.Repositories
{
    internal sealed class SliderRepository : Repository<Slider, ApplicationDbContext>, ISliderRepository
    {
        public SliderRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}