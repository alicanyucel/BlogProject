

using AutoMapper;
using BlogProject.Application.Features.Slider.CreateSlider;
using BlogProject.Application.Features.Slider.UpdateSlider;
using BlogProject.Domain;

namespace BlogProject.Application.Mapper
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<CreateSliderCommand, Slider>().ReverseMap();
            CreateMap<UpdateSliderByIdCommand, Slider>().ReverseMap();
        }
    }
}
