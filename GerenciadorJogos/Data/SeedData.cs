using GerenciadorJogos.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorJogos.Data.Seeds
{
    public static class SeedData
    {
        public static void Popular(ModelBuilder modelBuilder)
        {
            SeedPlataformas(modelBuilder);
            SeedGeneros(modelBuilder);
            SeedJogos(modelBuilder);
            SeedJogoPlataformas(modelBuilder);
            SeedJogoGeneros(modelBuilder);
        }


        private static void SeedPlataformas(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Plataforma>().HasData(
                new Plataforma { Id = 1, Nome = "Mobile" },
                new Plataforma { Id = 2, Nome = "Nintendo Switch 1" },
                new Plataforma { Id = 3, Nome = "Nintendo Switch 2" },
                new Plataforma { Id = 4, Nome = "PC" },
                new Plataforma { Id = 5, Nome = "PlayStation 4" },
                new Plataforma { Id = 6, Nome = "PlayStation 5" },
                new Plataforma { Id = 7, Nome = "Xbox One" },
                new Plataforma { Id = 8, Nome = "Xbox Series S|X" }
            );
        }

        private static void SeedGeneros(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genero>().HasData(
                new Genero { Id = 1, Nome = "Ação" },
                new Genero { Id = 2, Nome = "Aventura" },
                new Genero { Id = 3, Nome = "Caça" },
                new Genero { Id = 4, Nome = "Corrida" },
                new Genero { Id = 5, Nome = "Exploração" },
                new Genero { Id = 6, Nome = "Estratégia" },
                new Genero { Id = 7, Nome = "FPS" },
                new Genero { Id = 8, Nome = "Indie" },
                new Genero { Id = 9, Nome = "Metroidvania" },
                new Genero { Id = 10, Nome = "Plataforma" },
                new Genero { Id = 11, Nome = "Roguelike" },
                new Genero { Id = 12, Nome = "RPG" },
                new Genero { Id = 13, Nome = "Simulação" },
                new Genero { Id = 14, Nome = "Soulslike" },
                new Genero { Id = 15, Nome = "Sobrevivência" }
            );
        }

        private static void SeedJogos(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jogo>().HasData(

                new Jogo
                {
                    Id = 1,
                    Titulo = "Elden Ring",
                    Ano = 2022,
                    Capa = "https://image.api.playstation.com/vulcan/ap/rnd/202110/2000/YMUoJUYNX0xWk6eTKuZLr5Iw.jpg"
                },
                new Jogo
                {
                    Id = 2,
                    Titulo = "Monster Hunter Rise",
                    Ano = 2021,
                    Capa = "https://www.monsterhunter.com/rise/assets/images/common/share.png"
                },
                new Jogo
                {
                    Id = 3,
                    Titulo = "Hollow Knight: Silksong",
                    Ano = 2025,
                    Capa = "https://assets.nintendo.com/image/upload/ar_16:9,c_lpad,w_1240/b_white/f_auto/q_auto/ncom/software/switch/70010000020840/60eebc8f7133f685eddbffbe43c8da617ba0a5d699f2008f9c31c6119d1792af"
                },
                new Jogo
                {
                    Id = 4,
                    Titulo = "The Elder Scrolls V: Skyrim Special Edition",
                    Ano = 2016,
                    Capa = "https://cdn1.epicgames.com/offer/c8738a4d1ead40368eab9688b3c7d737/EGS_SkyrimSpecialEdition_BethesdaGameStudios_S1_2560x1440-dcf7c2839f4a13b0d921a8f146c8c922"
                },
                new Jogo
                {
                    Id = 5,
                    Titulo = "Dead Cells",
                    Ano = 2018,
                    Capa = "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/588650/capsule_616x353.jpg?t=1757600364"
                },


                new Jogo
                {
                    Id = 6,
                    Titulo = "The Witcher 3: Wild Hunt",
                    Ano = 2015,
                    Capa = "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/292030/header.jpg"
                },
                new Jogo
                {
                    Id = 7,
                    Titulo = "Dark Souls III",
                    Ano = 2016,
                    Capa = "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/374320/header.jpg"
                },
                new Jogo
                {
                    Id = 8,
                    Titulo = "Red Dead Redemption 2",
                    Ano = 2018,
                    Capa = "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/1174180/header.jpg"
                },
                new Jogo
                {
                    Id = 9,
                    Titulo = "Hades",
                    Ano = 2020,
                    Capa = "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/1145360/header.jpg"
                },
                new Jogo
                {
                    Id = 10,
                    Titulo = "Bloodborne",
                    Ano = 2015,
                    Capa = "https://upload.wikimedia.org/wikipedia/en/1/15/Bloodborne_Cover.jpg"
                },


                new Jogo
                {
                    Id = 11,
                    Titulo = "Stardew Valley",
                    Ano = 2016,
                    Capa = "https://upload.wikimedia.org/wikipedia/en/8/82/Stardew_Valley_cover_art.jpg"
                },
                new Jogo
                {
                    Id = 12,
                    Titulo = "Cyberpunk 2077",
                    Ano = 2020,
                    Capa = "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/1091500/header.jpg"
                },
                new Jogo
                {
                    Id = 13,
                    Titulo = "Celeste",
                    Ano = 2018,
                    Capa = "https://upload.wikimedia.org/wikipedia/en/4/45/Celeste_cover_art.jpg"
                },
                new Jogo
                {
                    Id = 14,
                    Titulo = "Resident Evil 4 Remake",
                    Ano = 2023,
                    Capa = "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/2050650/header.jpg"
                },
                new Jogo
                {
                    Id = 15,
                    Titulo = "No Man's Sky",
                    Ano = 2016,
                    Capa = "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/275850/header.jpg"
                },


                new Jogo
                {
                    Id = 16,
                    Titulo = "Doom Eternal",
                    Ano = 2020,
                    Capa = "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/782330/header.jpg"
                },
                new Jogo
                {
                    Id = 17,
                    Titulo = "Forza Horizon 5",
                    Ano = 2021,
                    Capa = "https://upload.wikimedia.org/wikipedia/en/7/7d/Forza_Horizon_5_cover_art.jpg"
                },
                new Jogo
                {
                    Id = 18,
                    Titulo = "The Legend of Zelda: Tears of the Kingdom",
                    Ano = 2023,
                    Capa = "https://upload.wikimedia.org/wikipedia/en/a/a3/The_Legend_of_Zelda_Tears_of_the_Kingdom_box_art.jpg"
                }
            );
        }

        private static void SeedJogoPlataformas(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JogoPlataforma>().HasData(
                new JogoPlataforma { JogoId = 1, PlataformaId = 6, Valor = 299.90m }, // Elden Ring - PS5
                new JogoPlataforma { JogoId = 1, PlataformaId = 4, Valor = 249.90m }, // Elden Ring - PC
                new JogoPlataforma { JogoId = 2, PlataformaId = 2, Valor = 199.90m }, // Monster Hunter Rise - Switch
                new JogoPlataforma { JogoId = 3, PlataformaId = 4, Valor = 149.90m }, // Hollow Knight: Silksong - PC
                new JogoPlataforma { JogoId = 4, PlataformaId = 5, Valor = 159.90m }, // Skyrim - PS4
                new JogoPlataforma { JogoId = 5, PlataformaId = 4, Valor = 79.90m },  // Dead Cells - PC
                new JogoPlataforma { JogoId = 6, PlataformaId = 5, Valor = 129.90m }, // The Witcher 3 - PS4
                new JogoPlataforma { JogoId = 7, PlataformaId = 5, Valor = 189.90m }, // Dark Souls III - PS4
                new JogoPlataforma { JogoId = 8, PlataformaId = 7, Valor = 249.90m }, // Red Dead Redemption 2 - Xbox One
                new JogoPlataforma { JogoId = 9, PlataformaId = 4, Valor = 79.90m },  // Hades - PC
                new JogoPlataforma { JogoId = 10, PlataformaId = 5, Valor = 179.90m } // Bloodborne - PS4
            );
        }

        private static void SeedJogoGeneros(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JogoGenero>().HasData(
                new JogoGenero { JogoId = 1, GeneroId = 14 }, // Elden Ring - Soulslike
                new JogoGenero { JogoId = 1, GeneroId = 12 }, // Elden Ring - RPG
                new JogoGenero { JogoId = 2, GeneroId = 1 },  // Monster Hunter Rise - Ação
                new JogoGenero { JogoId = 2, GeneroId = 3 },  // Monster Hunter Rise - Caça
                new JogoGenero { JogoId = 3, GeneroId = 9 },  // Silksong - Metroidvania
                new JogoGenero { JogoId = 3, GeneroId = 10 }, // Silksong - Plataforma
                new JogoGenero { JogoId = 4, GeneroId = 12 }, // Skyrim - RPG
                new JogoGenero { JogoId = 4, GeneroId = 2 },  // Skyrim - Aventura
                new JogoGenero { JogoId = 5, GeneroId = 11 }, // Dead Cells - Roguelike
                new JogoGenero { JogoId = 5, GeneroId = 10 }  // Dead Cells - Plataforma
            );
        }
    }
}

