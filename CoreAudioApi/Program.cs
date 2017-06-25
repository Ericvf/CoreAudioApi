using System.Threading.Tasks;

namespace CoreAudioApi
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainTask = Task.Run(async () => await MainAsync());
            mainTask.Wait();
        }

        static async Task MainAsync()
        {
            await CoreAudioApi.MuteProcess("chrome", volumeStep: 0.05f, millisDelay: 50);
        }
    }
}
