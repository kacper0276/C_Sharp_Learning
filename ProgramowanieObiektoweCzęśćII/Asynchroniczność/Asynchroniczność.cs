namespace ProgramowanieObiektoweCzęśćII.Asynchroniczność
{
    internal class Asynchroniczność
    {
        public Asynchroniczność()
        {
            var fileOperation = new FileOperation();
            var watcher = new Watcher();
            var path = "path";

            /*try
            {
                fileOperation.ReadFileVoidAsync(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }*/
            var task = fileOperation.ReadFileAsync(path);
            var task1 = watcher.WatchAsync();
            var task2 = watcher.WatchAsync();
            var task3 = watcher.WatchAsync();
            var task4 = watcher.WatchAsync();
            var task5 = watcher.WatchAsync();
            var task6 = watcher.WatchAsync();
            var task7 = watcher.WatchAsync();
            var task8 = watcher.WatchAsync();
            var task9 = watcher.WatchAsync();
            var task10 = watcher.WatchAsync();
            var task11 = watcher.WatchAsync();
            var task12 = watcher.WatchAsync();
            var task13 = watcher.WatchAsync();
            var task14 = watcher.WatchAsync();
            var task15 = watcher.WatchAsync();
            var task16 = watcher.WatchAsync();
            var task17 = watcher.WatchAsync();
            var task18 = watcher.WatchAsync();
            var task19 = watcher.WatchAsync();
            var task20 = watcher.WatchAsync();
            //await Task.WhenAll(task1, task2, task3, task4, task5, task6, task7, task8, task9, task10,
              //  task11, task12, task13, task14, task15, task16, task17, task18, task19, task20);
            //await task;
        }
    }

    class FileOperation
    {
        public void ReadFile(string filePath)
        {
            Console.WriteLine($"Reading file from {filePath} ...");
            Thread.Sleep(3000);
            Console.WriteLine($"Read file from {filePath} ...");
        }

        public async Task ReadFileAsync(string filePath)
        {
            Console.WriteLine($"Reading file from {filePath} ...");
            await Task.Delay(3000);
            Console.WriteLine($"Read file from {filePath} ...");
        }

        /*
         * public async Task<int> ReadFileAsync(string filePath)
        {
            Console.WriteLine($"Reading file from {filePath} ...");
            await Task.Delay(3000);
            Console.WriteLine($"Read file from {filePath} ...");
            return 10;
        }
         */

        public async void ReadFileVoidAsync(string filePath)
        {
            Console.WriteLine($"Reading file from {filePath} ...");
            await Task.Delay(3000);
            throw new InvalidOperationException("Some error occured");
        }
    }

    class Watcher
    {
        public async Task WatchAsync()
        {
            Console.WriteLine("Watching ...");
            await Task.Delay(100);
            Console.WriteLine("Watched");
        }
    }
}
