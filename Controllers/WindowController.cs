using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using window_backend.Data;
using Microsoft.AspNetCore.Hosting;
using window_backend.Services.Interfaces;

namespace window_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WindowController : ControllerBase
    {
        private readonly ILogger<WindowController> _logger;
        private readonly IWindowService _windowService;

        public WindowController(ILogger<WindowController> logger, IWindowService windowService)
        {
            _logger = logger;
            _windowService = windowService;
        }

        [HttpGet]
        public async Task<Window> Get()
        {
            try
            {
                return await _windowService.GetWindow();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw new ApplicationException(ex.Message, ex);
            }
        }
        [HttpPost]
        public async Task<Window> Post(Window window)
        {
            try
            {
                return await _windowService.UpdateWindow(window);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw new ApplicationException(ex.Message, ex);
            }
        }
    }
}
