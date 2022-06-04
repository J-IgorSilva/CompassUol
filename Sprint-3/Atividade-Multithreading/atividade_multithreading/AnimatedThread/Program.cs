using AnimatedThread.JsonData;
using AnimatedThread.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AnimatedThread
{
    class Program
    {
        static Dictionary<string, string> frameSprites = new Dictionary<string, string>();
        static IDatabase _database;
        static IDatabase Database
        {
            get
            {
                if (_database == null)
                    _database = new Database();

                return _database;
            }
        }

        static async Task Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
           
            int counter;
            var personId = 1;
            var peopleOutputTaks = new List<Task<Output>>();
            var peopleOutput = new List<Output>();

            while (peopleOutputTaks.Count < 88)
            {
                counter = 0;

                for (int i = 0; i < 9; i++)
                {
                    Console.SetCursorPosition(0, 0);

                    DrawLoopMainThread(i, counter);

                    await Task.Delay(200);

                    counter++;
                }

                Console.WriteLine("-- INICIANDO PROCESSAMENTO --");
                //TODO: Iniciar tarefas abaixo desta linha

                peopleOutputTaks.Add(Task.Run(() => GetOutputByUserId(personId++)));
            }

            Task.WaitAll(peopleOutputTaks.ToArray());

            peopleOutputTaks.ForEach(x =>
            {
                peopleOutput.Add(x.Result);
            });

            JsonUtil.ExportJsonToFile(peopleOutput);

            Console.WriteLine("---- FINALIZADO ---");
            Console.ReadLine();
        }

        static async Task<Output> GetOutputByUserId(int personId)
        {
            var person = Database.GetPeople().FirstOrDefault(x => x.Id == personId);
            var personSongs = await Database.GetPersonSongsAsync(personId);
            var favoriteSong = Database.GetSongs().FirstOrDefault(x => x.Id == personSongs.FavoriteSongId);
            var otherSongs = Database.GetSongs().Where(x => personSongs.SongsIds.Contains(x.Id));
            var favoriteSongArtist = Database.GetArtists().FirstOrDefault(x => x.Id == favoriteSong.ArtistId);

            var ortherSongsArtistsId = otherSongs.Select(x => x.ArtistId);
            var ortherSongsArtists = Database.GetArtists().Where(x => ortherSongsArtistsId.Contains(x.Id));

            var list = new List<ArtistSongs>();

            foreach (var artist in ortherSongsArtists)
            {
                var artistSongs = Database.GetSongs().Where(x => x.ArtistId == artist.Id);
                list.Add(new ArtistSongs(artist, artistSongs));
            }

            return new Output(person.Name, person.Age, favoriteSong.Name, favoriteSongArtist.Name, favoriteSong.Year, otherSongs.Select(x => x.Name), list);
        }

        static void DrawLoopMainThread(int i, int counter)
        {
            switch (counter % (i + 1))
            {
                case 0:
                    {
                        const string frameName = nameof(Animations.frame8);

                        Console.Write(GetFrameLines(frameName, Animations.frame8));

                        break;
                    };
                case 1:
                    {
                        const string frameName = nameof(Animations.frame7);

                        Console.Write(GetFrameLines(frameName, Animations.frame7));
                        break;
                    };
                case 2:
                    {
                        const string frameName = nameof(Animations.frame6);

                        Console.Write(GetFrameLines(frameName, Animations.frame6));
                        break;
                    };
                case 3:
                    {
                        const string frameName = nameof(Animations.frame5);

                        Console.Write(GetFrameLines(frameName, Animations.frame5));
                        break;
                    };
                case 4:
                    {
                        const string frameName = nameof(Animations.frame4);

                        Console.Write(GetFrameLines(frameName, Animations.frame4));
                        break;
                    };
                case 5:
                    {
                        const string frameName = nameof(Animations.frame3);

                        Console.Write(GetFrameLines(frameName, Animations.frame3));
                        break;
                    };
                case 6:
                    {
                        const string frameName = nameof(Animations.frame2);

                        Console.Write(GetFrameLines(frameName, Animations.frame2));
                        break;
                    };
                case 7:
                    {
                        const string frameName = nameof(Animations.frame1);

                        Console.Write(GetFrameLines(frameName, Animations.frame1));
                        break;
                    }
                case 8:
                    {
                        const string frameName = nameof(Animations.frame0);

                        Console.Write(GetFrameLines(frameName, Animations.frame0));
                        break;
                    }

            }

        }

        static string GetFrameLines(string frameName, string frame)
        {
            if (!frameSprites.ContainsKey(frameName))
            {
                var frameLines = frame.Split("<br>");
                var sb = new StringBuilder();
                foreach (var item in frameLines)
                {
                    sb.AppendLine(item);
                }
                frameSprites.Add(frameName, sb.ToString());
            }

            return frameSprites[frameName];
        }
    }
}
