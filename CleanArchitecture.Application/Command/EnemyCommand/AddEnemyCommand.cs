using CleanArchitecture.Application.DTOs;
using CleanArchitecture.Domain.Model;
using MediatR;

namespace CleanArchitecture.Application.Command.EnemyCommand;

//public record AddEnemyCommand(string EnemyName, string EnemyDescreption) : IRequest<Enemy>;
public class AddEnemyCommand : IRequest<Enemy>
{
    public AddEnemyCommandRequest Enemy { get; set; }
}