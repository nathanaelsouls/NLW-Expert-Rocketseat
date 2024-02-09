using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories.DataAccess;

public class AuctionRepository : IAuctionRepository
{
    private readonly RocketseatAuctionDbContext _dbContext;

    public AuctionRepository(RocketseatAuctionDbContext dbContext) => _dbContext = dbContext;

    public List<Auction> GetCurrent()
    {
        return [.._dbContext.Auctions.Include(auction => auction.Items)] ;
    }
}
