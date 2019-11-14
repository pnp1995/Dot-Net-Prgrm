using Common.CollaboratorModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Interface
{
    public interface ICollaborator
    {
     Task<string> AddCollaborator(CollaboratorModel collaboratorModel);
     Task<string> UpdateCollaborator(CollaboratorModel collaboratorModel);
    Task<string> DeleteCollaborator(int Id);
    List<CollaboratorModel> List(int Noteid);

    }
}
