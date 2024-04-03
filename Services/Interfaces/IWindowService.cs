using window_backend.Data;

namespace window_backend.Services.Interfaces
{
    public interface IWindowService
    {
        Task<Window> GetWindow();
        Task<Window> UpdateWindow(Window window);
    }
}
