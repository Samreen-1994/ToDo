import { HelperService } from './../../../services/helper/helper.service';
import { EmployeeService } from './../../../services/employee/employee.service';
import { Employee } from './../../../models/employee';
import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-create-employee',
  templateUrl: './create-employee.component.html',
  styleUrls: ['./create-employee.component.css']
})
export class CreateEmployeeComponent implements OnInit {
  emp = new Employee();
  empList = new Array<Employee>();

  constructor(private empService: EmployeeService, private toast: ToastrService, public helper: HelperService) { }

  ngOnInit() {
    this.getEmployees();
  }

  createEmployee() {
    this.empService.createEmployee(this.emp).subscribe(
      (res) => {
        this.toast.success('employee added');
        this.getEmployees();
      },
      (err) => {
        this.toast.error('some error has occured');
      }
    );
  }

  getEmployees() {
    this.empService.getEmployees().subscribe(
      (res) => {
        this.empList = res;
        if (this.empList) {
          this.helper.selectedEmployee = this.empList[0];
          this.helper.fetchToDoEmployee();
        }
      },
      (err) => {
        this.toast.error('some error has occured');
      }
    );
  }

  fetchToDoItems(e: Employee) {
    this.helper.selectedEmployee = e;
    this.helper.fetchToDoEmployee();
  }
}
