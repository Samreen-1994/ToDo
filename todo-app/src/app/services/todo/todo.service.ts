import { Todo } from './../../models/todo';
import { Employee } from './../../models/employee';
import { environment } from './../../../environments/environment';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TodoService {
  endPointUrl: string = environment.baseUrl;

  constructor(private http: HttpClient) { }

  fetchEmployeeToDoItems(employeeId: number): Observable<any> {
    return this.http.get(this.endPointUrl + "/ToDo/GetEmployeeTasks?employeeId=" + employeeId);
  }

  createToDoItem(toDo: Todo): Observable<any> {
    return this.http.post(this.endPointUrl + "/Todo/Create", toDo);
  }
}
