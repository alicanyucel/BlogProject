

using BlogProject.Domain;
using MediatR;

namespace BlogProject.Application;

public sealed record GetAllSliderQuery() : IRequest<List<Slider>>;
