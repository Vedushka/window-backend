using Microsoft.AspNetCore.Hosting;
using System.Text.Json;
using window_backend.Data;
using window_backend.Services.Interfaces;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace window_backend.Services
{
    public class WindowService : IWindowService
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        public WindowService(IHostingEnvironment hostingEnvironment) {
            _hostingEnvironment = hostingEnvironment;
        }
        public async Task<Window> GetWindow()
        {
            string fullPath = _hostingEnvironment.ContentRootPath + "/Data/window.json";
            var windowJson = await System.IO.File.ReadAllTextAsync(fullPath);

            if (windowJson == null) throw new NullReferenceException(nameof(windowJson));

            var window = JsonSerializer.Deserialize<Window>(windowJson);

            if (window == null) throw new NullReferenceException(nameof(window));

            return window;
        }

        public async Task<Window> UpdateWindow(Window window)
        {
            string fullPath = _hostingEnvironment.ContentRootPath + "/Data/window.json";
            var windowJson = JsonSerializer.Serialize<Window>(window);
            if (windowJson == null) throw new NullReferenceException(nameof(windowJson));
            await System.IO.File.WriteAllTextAsync(fullPath, windowJson);

            return window;

        }
    }
}
