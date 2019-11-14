using Common.CollaboratorModel;
using FundooRepository.Context;
using FundooRepository.FundooInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Repository
{
    public class CollaboratorRepository : ICollaboratorRepo
    {
        private readonly UserContext userContext;
        public CollaboratorRepository(UserContext userContext)
        {
            this.userContext = userContext;
        }
        public Task AddCollaborator(CollaboratorModel collaboratorModel)
        {   
            CollaboratorModel collaboratorModel1 = new CollaboratorModel()
            {
                Id = collaboratorModel.Id,
                SenderEmail = collaboratorModel.SenderEmail,
                Noteid = collaboratorModel.Noteid,
                ReceiverEmail = collaboratorModel.ReceiverEmail
            };
            userContext.CollaboratorDetail.Add(collaboratorModel);
            return Task.Run(() => userContext.SaveChanges());
        }
        public Task UpdateCollaborator(CollaboratorModel collaboratorModel)
        {
        CollaboratorModel collaborator  = userContext.CollaboratorDetail.Where(p => p.Id == collaboratorModel.Id).FirstOrDefault();
            if (collaborator != null)
            {
                collaborator.SenderEmail = collaboratorModel.SenderEmail;
                collaborator.Noteid = collaboratorModel.Noteid;
                collaborator.ReceiverEmail = collaboratorModel.ReceiverEmail;
                userContext.CollaboratorDetail.Update(collaborator);
            }
            return Task.Run(() => userContext.SaveChanges());
        }
        public Task DeleteCollaborator(int Id)
        {
            CollaboratorModel collaborator = userContext.CollaboratorDetail.Where(p => p.Id == Id).FirstOrDefault();
            if (collaborator != null)
            {
                userContext.CollaboratorDetail.Remove(collaborator);
            }
             return Task.Run(() => userContext.SaveChanges());          
        }
        public List<CollaboratorModel> ListCollaborator(int Noteid)
        {
            bool note = userContext.CollaboratorDetail.Any(p => p.Noteid == Noteid);
            if (note)
            {
                return userContext.CollaboratorDetail.Where(p => p.Noteid == Noteid).ToList();
            }
            else
            {
                return null;
            }
        }
    }
}
