import { Employee } from './../../models/employee';
import { environment } from './../../../environments/environment';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  endPointUrl: string = environment.baseUrl;

  constructor(private httpClient: HttpClient) { }

  createEmployee(employee: Employee): Observable<any> {
    return this.httpClient.post(this.endPointUrl + "/Employee/Create", employee);
  }

  getEmployees(): Observable<any> {
    return this.httpClient.get(this.endPointUrl + "/Employee");
  }
}
