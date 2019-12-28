using Common.CollaboratorModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.FundooInterface
{
    public interface ICollaboratorRepo
    {
        Task AddCollaborator(CollaboratorModels collaboratorModel);
        Task UpdateCollaborator(CollaboratorModels collaboratorModel);
        Task DeleteCollaborator(int Id);
        List<CollaboratorModels> ListCollaborator(int Noteid);
    }
}
