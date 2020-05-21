import { Todo } from './../../../models/todo';
import { TodoService } from './../../../services/todo/todo.service';
import { HelperService } from './../../../services/helper/helper.service';
import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-create-todo',
  templateUrl: './create-todo.component.html',
  styleUrls: ['./create-todo.component.css']
})
export class CreateTodoComponent implements OnInit {
  toDo = new Todo();
  constructor(private helper: HelperService, private todoService: TodoService, private toast: ToastrService) { }

  ngOnInit() {
  }

  createToDo() {
    this.toDo.employeeid = this.helper.selectedEmployee.employee_id;
    this.todoService.createToDoItem(this.toDo).subscribe(
      (res) => {
        this.helper.fetchToDoEmployee();
        this.toast.success("created");
      },
      (err) => {
        this.toast.error('some error occured');
      }
    );
  }

}
