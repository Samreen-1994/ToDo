import { Employee } from './../../../models/employee';
import { Todo } from './../../../models/todo';
import { HelperService } from './../../../services/helper/helper.service';
import { TodoService } from './../../../services/todo/todo.service';
import { Component, OnInit, Output } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { EventEmitter } from 'protractor';

@Component({
  selector: 'app-show-todo',
  templateUrl: './show-todo.component.html',
  styleUrls: ['./show-todo.component.css']
})
export class ShowTodoComponent implements OnInit {
  todoItems = new Array<Todo>();
  selectedTask = new Todo();

  constructor(private todoService: TodoService, private helper: HelperService, private toast: ToastrService) {
    this.helper.configObservable.subscribe(value => {
      this.fetchToDoEmployee();
    }
    );
  }

  ngOnInit() {

  }

  fetchToDoEmployee() {
    this.todoService.fetchEmployeeToDoItems(this.helper.selectedEmployee.employee_id).subscribe(
      (res) => {
        this.todoItems = res;
      },
      (err) => {
        this.toast.error('some error has occured');
      }
    );
  }

  selectTask(selectedTask: Todo) {
    this.selectedTask = selectedTask;
  }

  GetPriority(p: number) {
    if (p == 1) {
      return "High";
    }
    else if (p == 2) {
      return "Medium";
    }
    else if (p == 3) {
      return "Low";
    }
  }
}
