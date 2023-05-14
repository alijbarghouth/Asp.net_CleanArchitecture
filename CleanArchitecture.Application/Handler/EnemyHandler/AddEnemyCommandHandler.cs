using CleanArchitecture.Application.Command.EnemyCommand;
using CleanArchitecture.Application.IRepository;
using CleanArchitecture.Domain.Model;
using CleanArchitecture.Domain.Shared;
using Mapster;
using MediatR;

namespace CleanArchitecture.Application.Handler.EnemyHandler;

public sealed class AddEnemyHandler : IRequestHandler<AddEnemyCommand, Enemy>
{
    private readonly IApplicationDBContext _dbContext;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRepository<Enemy> _enemyRepository;
    public AddEnemyHandler(IApplicationDBContext dbContext, IUnitOfWork unitOfWork, IRepository<Enemy> enemyRepository)
    {
        _dbContext = dbContext;
        _unitOfWork = unitOfWork;
        _enemyRepository = enemyRepository;
    }

    public async Task<Enemy> Handle(AddEnemyCommand request, CancellationToken cancellationToken)
    {
        var enemy = request.Enemy.Adapt<Enemy>();
        await _enemyRepository.AddAsync(enemy);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return enemy;
    }
}