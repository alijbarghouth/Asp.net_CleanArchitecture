using CleanArchitecture.Application.Command.EnemyCommand;
using CleanArchitecture.Domain.Model;
using CleanArchitecture.Domain.Shared;
using Mapster;
using MediatR;

namespace CleanArchitecture.Application.Handler.EnemyHandler;

public sealed class AddEnemyHandler : IRequestHandler<AddEnemyCommand, Enemy>
{
    private readonly IApplicationDBContext _dbContext;

    public AddEnemyHandler(IApplicationDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Enemy> Handle(AddEnemyCommand request, CancellationToken cancellationToken)
    {
        var enemy = request.Enemy.Adapt<Enemy>();
        await _dbContext.Enemies.AddAsync(enemy, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);

        return enemy;
    }
}