

using Microsoft.AspNetCore.Mvc;
using BlogProject.Domain;
using BlogProject.Infrastructure.DataContext;

[ApiController]
[Route("api/[controller]")]
public class SliderController : ControllerBase
{
    private readonly ApplicationDbContext _dbContext;

    // DbContext'i constructor ile alıyoruz
    public SliderController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    // POST: api/slider/create
    [HttpPost("create")]
    public async Task<IActionResult> CreateSlider([FromBody] Slider slider)
    {
        if (slider == null)
        {
            return BadRequest("Slider verileri eksik.");
        }

        // Slider'ı oluşturuyoruz ve veritabanına ekliyoruz
        slider.SliderId = Guid.NewGuid(); // Yeni bir Guid oluşturuyoruz
        slider.Created = DateTime.UtcNow; // Oluşturulma tarihi
        slider.CreatedBy = "System"; // Kim tarafından oluşturulduğunu belirtiyoruz
        slider.Modified = DateTime.UtcNow; // İlk oluşturma zamanını da Modified olarak belirliyoruz

        // Slider'ı veritabanına ekliyoruz
        await _dbContext.Sliders.AddAsync(slider);

        // Değişiklikleri kaydediyoruz
        await _dbContext.SaveChangesAsync();

        // Başarılı bir şekilde eklediğimiz SliderId'yi döndürüyoruz
        return Ok(new { SliderId = slider.SliderId });
    }
}
