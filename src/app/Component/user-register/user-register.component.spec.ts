import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { UserRegisterComponent } from './user-register.component';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { MatFormFieldModule, MatInputModule } from '@angular/material';
import { MatButtonModule, MatCardModule } from '@angular/material';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
describe('UserRegisterComponent', () => {
  let component: UserRegisterComponent;
  let fixture: ComponentFixture<UserRegisterComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UserRegisterComponent ],
      imports:[ReactiveFormsModule,FormsModule,
        MatSnackBarModule,
        BrowserModule,
        MatFormFieldModule,
        MatInputModule,
        MatCardModule,
        MatButtonModule,
        MatSnackBarModule,
        BrowserAnimationsModule,
        HttpClientModule]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UserRegisterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
  it('Form should be invalid', async(() => {
    component.registerForm.controls['firstName'].setValue('');
    component.registerForm.controls['lastName'].setValue('');
    component.registerForm.controls['email'].setValue('');
    component.registerForm.controls['password'].setValue('');
    component.registerForm.controls['confirmPassword'].setValue('');
    expect(component.registerForm.valid).toBeFalsy();
  }));
  it('Form should be valid', async(() => {
    component.registerForm.controls['firstName'].setValue('pritam');
    component.registerForm.controls['lastName'].setValue('yadav');
    component.registerForm.controls['email'].setValue('pnp5657@gmail.com');
    component.registerForm.controls['password'].setValue('12345');
    component.registerForm.controls['confirmPassword'].setValue('12345');
    expect(component.registerForm.valid).toBeTruthy();
  }));
});
