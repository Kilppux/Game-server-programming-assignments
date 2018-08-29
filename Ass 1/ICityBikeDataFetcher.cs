using System.Threading.Tasks;

namespace Ass_1
{
    public interface ICityBikeDataFetcher
    {
        Task<int> GetBikeCountInStation(string stationName);
    }
}