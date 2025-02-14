

using AutoMapper;
using BlogProject.Application.Features.Slider.AddSlider;
using BlogProject.Application.Features.Slider.UpdateSlider;
using BlogProject.DomaiN;

namespace BlogProject.Application.Mapping
{
    public class MapClass:Profile
    {
        public MapClass()
        {
            CreateMap<UpdateSliderByIdCommand,Slider>().ReverseMap();
            CreateMap<AddSliderCommand,Slider>().ReverseMap();
        }
    }
}
