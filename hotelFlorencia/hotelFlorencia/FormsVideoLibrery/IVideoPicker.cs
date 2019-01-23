using System;
using System.Threading.Tasks;

namespace FormsVideoLibrery
{
    public interface IVideoPicker
    {
        Task<string> GetVideoFileAsync();
    }
}
