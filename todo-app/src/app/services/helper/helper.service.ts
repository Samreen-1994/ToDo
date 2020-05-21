import { Employee } from './../../models/employee';
import { Injectable, Output } from '@angular/core';
import { EventEmitter } from 'protractor';
import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class HelperService {
  public selectedEmployee: Employee;
  public configObservable = new Subject();

  constructor() { }

  fetchToDoEmployee() {
    this.configObservable.next();
  }
}
