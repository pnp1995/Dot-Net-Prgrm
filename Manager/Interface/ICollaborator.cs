using Common.CollaboratorModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Interface
{
    public interface ICollaborator
    {
     Task<string> AddCollaborator(CollaboratorModels collaboratorModel);
     Task<string> UpdateCollaborator(CollaboratorModels collaboratorModel);
    Task<string> DeleteCollaborator(int Id);
    List<CollaboratorModels> List(int Noteid);

    }
}
