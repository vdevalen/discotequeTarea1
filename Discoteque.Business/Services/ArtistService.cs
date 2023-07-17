using Discoteque.Business.IServices;
using Discoteque.Data.Models;

namespace Discoteque.Business.Services;

public class ArtistService : IArtistService
{

    public async Task<Artist> GetById(int id)
    {
        throw new NotImplementedException();
    }

    async Task<IEnumerable<Artist>> IArtistService.CreateArtist(Artist artist)
    {
        List<Artist> artistsList = new();
        Random random = new();

        Artist newArtist = new()
        {
            Id = random.Next(1, 100),
            Name = artist.Name,
            Label = artist.Label,
            IsOnTour = artist.IsOnTour
        };

        artistsList.Add(newArtist);

        return artistsList;
    }

    public async Task<IEnumerable<Artist>> GetArtistsAsync()
    {
        Random random = new();
        List<Artist> artistsLlist = new()
        {
            new Artist() { Id = random.Next(1, 100), Name = "Shakira", Label = "Label 1", IsOnTour = true },
            new Artist() { Id = random.Next(1, 100), Name = "Juanes", Label = "Label 2", IsOnTour = false },
            new Artist() { Id = random.Next(1, 100), Name = "Karol G", Label = "Label 3", IsOnTour = true },
            new Artist() { Id = random.Next(1, 100), Name = "Selena", Label = "Label 4", IsOnTour = false },
            new Artist() { Id = random.Next(1, 100), Name = "Adele", Label = "Label 5", IsOnTour = true }
        };

        return artistsLlist;
    }

    public Task<Artist> UpdateArtist(Artist artist)
    {
        throw new NotImplementedException();
    }
}