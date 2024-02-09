using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    private readonly IAuctionRepository _repository;

    public GetCurrentAuctionUseCase(IAuctionRepository auctionRepository) => _repository = auctionRepository;

    public List<Auction?> Execute()
    {
        return _repository.GetCurrent();        
    }
}
