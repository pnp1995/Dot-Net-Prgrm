import { FlexLayoutModule } from '@angular/flex-layout';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {AppRoutingModule} from './app-routing.module';
import { AppComponent } from './app.component';
import {  MatInputModule, MatFormFieldModule, MatNativeDateModule } from '@angular/material';
import {MatCardModule} from '@angular/material/card';
import { UserRegisterComponent } from './Component/user-register/user-register.component';
import { HttpClientModule } from '@angular/common/http';
import{LoginComponent} from './Component/login/login.component'
import { FormsModule ,ReactiveFormsModule } from '@angular/forms';
import { ServiceCardComponent } from './Component/service-card/service-card.component';
import {MatButtonModule} from '@angular/material/button';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './Component/dashboard/dashboard.component';
import {MatIconModule} from '@angular/material/icon';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatButtonToggleModule} from '@angular/material/button-toggle';
import {MatSidenavModule} from '@angular/material/sidenav';
import { ResetPasswordComponent } from './Component/reset-password/reset-password.component';
import { ForgetPasswordComponent } from './Component/forget-password/forget-password.component';
import {SocialLoginModule, AuthServiceConfig, GoogleLoginProvider,FacebookLoginProvider} from "angular-6-social-login";
import {MatMenuModule} from '@angular/material/menu';
import { NotesComponent } from './Component/notes/notes.component';
import {MatDividerModule} from '@angular/material/divider';
import { NotesDisplayComponent } from './Component/notes-display/notes-display.component';
import { GetNotesComponent } from './Component/get-notes/get-notes.component';
import { RemainderComponent } from './Component/remainder/remainder.component';
import {MatDatepickerModule} from '@angular/material/datepicker';
import { EditComponent } from './Component/edit/edit.component';
import {MatDialogModule} from '@angular/material/dialog';
import {MatTooltipModule} from '@angular/material/tooltip';
import { CollaboratorComponent } from './Component/collaborator/collaborator.component';
import { LabelComponent } from './Component/label/label.component';
import { ArchiveComponent } from './Component/archive/archive.component';
import { TrashComponent } from './Component/trash/trash.component';

  // Config..
export function getAuthServiceConfigs()  
{
let config = new AuthServiceConfig([
  {
    id: GoogleLoginProvider.PROVIDER_ID,
    provider: new GoogleLoginProvider("1053317041053-lfm6qlacovas62a6ka12ro7e7n4obqtj.apps.googleusercontent.com")
  },
  {
    id: FacebookLoginProvider.PROVIDER_ID,
    provider: new FacebookLoginProvider("727119261141721")
  }
]);
  return config;
}

@NgModule({
  declarations: [
    AppComponent,
    UserRegisterComponent,
    LoginComponent,
    ServiceCardComponent,
    DashboardComponent,
    ResetPasswordComponent,
    ForgetPasswordComponent,
    NotesComponent,
    NotesDisplayComponent,
    GetNotesComponent,
    RemainderComponent,
    EditComponent,
    CollaboratorComponent,
    LabelComponent,
    ArchiveComponent,
    TrashComponent,
    
  ],
  imports: [
    BrowserModule,
    MatFormFieldModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    MatInputModule,
    FormsModule,
    ReactiveFormsModule,
    MatCardModule,
    HttpClientModule,
    MatButtonModule,
    RouterModule,
    MatIconModule,
    MatToolbarModule,
    MatButtonToggleModule,MatSidenavModule,
    SocialLoginModule,
    MatMenuModule,
    MatDividerModule,
    FlexLayoutModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatDialogModule,
    MatTooltipModule
  ],
  entryComponents : [EditComponent,
    LabelComponent,CollaboratorComponent
   ],
  providers: [
    {
      provide: AuthServiceConfig,
      useFactory: getAuthServiceConfigs
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
