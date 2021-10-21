using System.Collections.Generic;
using api.Models;

namespace api
{
    public class MoviesDataStore
    {
        public static MoviesDataStore Current { get; } = new MoviesDataStore();
        public List<MovieDto> Movies { get; set; }
        public MoviesDataStore()
        {
            Movies = new List<MovieDto>(){
                new MovieDto(){
                    Id = 1,
                    Name = "Pelicula 1",
                    Description = "Descripción de la película 1",
                    Casts = new List<CastDto>(){
                        new CastDto(){
                            Id = 1,
                            Name = "Actor 1",
                            Character= "Personaje 1"},
                        new CastDto(){
                            Id = 2,
                            Name = "Actor 2",
                            Character= "Personaje 2"},
                        new CastDto(){
                            Id = 3,
                            Name = "Actor 3",
                            Character= "Personaje 3"},
                    }
                },
                 new MovieDto(){
                    Id = 2,
                    Name = "Pelicula 2",
                    Description = "Descripción de la película 2",
                     Casts = new List<CastDto>(){
                        new CastDto(){
                            Id = 1,
                            Name = "Actor 1",
                            Character= "Personaje 1"},
                        new CastDto(){
                            Id = 2,
                            Name = "Actor 2",
                            Character= "Personaje 2"},
                        new CastDto(){
                            Id = 3,
                            Name = "Actor 3",
                            Character= "Personaje 3"},
                    }
                },
                new MovieDto(){
                    Id = 3,
                    Name = "Pelicula 3",
                    Description = "Descripción de la película 3",
                     Casts = new List<CastDto>(){
                        new CastDto(){
                            Id = 1,
                            Name = "Actor 1",
                            Character= "Personaje 1"},
                        new CastDto(){
                            Id = 2,
                            Name = "Actor 2",
                            Character= "Personaje 2"},
                        new CastDto(){
                            Id = 3,
                            Name = "Actor 3",
                            Character= "Personaje 3"},
                    }
                },
            };
        }
    }
}