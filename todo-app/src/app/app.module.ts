import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmployeeComponent } from './components/employee/employee/employee.component';
import { CreateTodoComponent } from './components/todo/create-todo/create-todo.component';
import { ShowTodoComponent } from './components/todo/show-todo/show-todo.component';
import { CreateEmployeeComponent } from './components/employee/create-employee/create-employee.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { ToastrModule } from 'ngx-toastr';

@NgModule({
  declarations: [
    EmployeeComponent,
    CreateTodoComponent,
    ShowTodoComponent,
    CreateEmployeeComponent,
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ToastrModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
