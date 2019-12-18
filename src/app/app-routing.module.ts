import { AdminLoginComponent } from './Component/admin-login/admin-login.component';
import { AdminDashboardComponent } from './Component/admin-dashboard/admin-dashboard.component';
import { AdminComponent } from './Component/admin/admin.component';
import { TrashComponent } from './Component/trash/trash.component';
import { EditComponent } from './Component/edit/edit.component';
import { NotesDisplayComponent } from './Component/notes-display/notes-display.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { UserRegisterComponent} from './Component/user-register/user-register.component';
import {LoginComponent} from './Component/login/login.component';
import {ServiceCardComponent} from './Component/service-card/service-card.component';
import {DashboardComponent} from './Component/dashboard/dashboard.component';
  import { from } from 'rxjs';
import { ResetPasswordComponent } from './Component/reset-password/reset-password.component';
import { ForgetPasswordComponent } from './Component/forget-password/forget-password.component';
import {NotesComponent} from './Component/notes/notes.component';
import { GetNotesComponent } from './Component/get-notes/get-notes.component';
import { ArchiveComponent } from './Component/archive/archive.component';
const appRoutes: Routes = ([
  {path : 'register', component: UserRegisterComponent},
  {path : 'login', component: LoginComponent},
  {path : 'card',component: ServiceCardComponent},
  {path : 'dash',component: DashboardComponent,
children :[
  {path : '',component:GetNotesComponent},
  {path : 'display',component:NotesDisplayComponent},
  {path : 'edit' ,component:EditComponent},
  {path : 'archive',component:ArchiveComponent},
  {path : 'notes',component:NotesComponent},
  {path : 'trash',component:TrashComponent}
]
},
{path : 'archive',component:ArchiveComponent},
// {path : 'Collabrator',component:CollaboratorComponent},
 {path : 'display',component:GetNotesComponent},
  {path : 'forget',component: ForgetPasswordComponent},
  {path : 'reset',component: ResetPasswordComponent},
  {path : 'notes',component:NotesComponent},
  {path : 'admin',component:AdminComponent},
  {path : 'admindash', component:AdminDashboardComponent},
  {path : 'loginadmin',component:AdminLoginComponent}

]);
@NgModule({
  imports: [
    CommonModule,
      RouterModule.forRoot(appRoutes,
        { enableTracing: true }
      )
    ],
    exports: [RouterModule]
  })
export class AppRoutingModule { }
