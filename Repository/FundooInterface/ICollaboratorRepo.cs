using Common.CollaboratorModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.FundooInterface
{
    public interface ICollaboratorRepo
    {
        Task AddCollaborator(CollaboratorModel collaboratorModel);
        Task UpdateCollaborator(CollaboratorModel collaboratorModel);
        Task DeleteCollaborator(int Id);
        List<CollaboratorModel> ListCollaborator(int Noteid);
    }
}
