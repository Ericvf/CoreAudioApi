using System.Threading.Tasks;

namespace CoreAudioApi
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await CoreAudioApi.MuteProcess("msedge", volumeStep: 0.05f, millisDelay: 50);
        }
    }
}
