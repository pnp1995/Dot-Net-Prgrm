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

const appRoutes: Routes = ([
  {path : 'register', component: UserRegisterComponent},
  {path : 'login', component: LoginComponent},
  {path : 'card',component: ServiceCardComponent},
  {path : 'dash',component: DashboardComponent},
  {path : 'forget',component: ForgetPasswordComponent},
  {path : 'reset',component: ResetPasswordComponent}
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
