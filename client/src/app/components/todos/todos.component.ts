import { Component, OnInit } from '@angular/core';
import { Todo, State } from '../../models/Todo';
import { TodoService } from '../../services/todo.service';
import { PagedObject } from '../../models/PagedObject'; 

@Component({
  selector: 'app-todos',
  templateUrl: './todos.component.html',
  styleUrls: ['./todos.component.scss']
})
export class TodosComponent implements OnInit {
  pagedObject: PagedObject;
  todos: Todo[];

  constructor(private todoService: TodoService) { }

  ngOnInit(): void {
    this.getAllTodos();
  }

  getAllTodos() {
    this.todoService.getTodos().subscribe(pagedObj => {
      this.pagedObject = pagedObj;
      this.todos = pagedObj.items.sort((a, b) => {
        if (a.status > b.status) {
          return -1;
        }else if (a.status < b.status) {
          return 1;
        }else {
          return 0;
        }
      });
    });
  }

  deleteTodo(event) {
    this.todoService.deleteTodo(event.id).subscribe(todo => {
      this.getAllTodos();
    });
  }

  addTodo(event) {
    this.todoService.addTodo(event).subscribe(todo => {
      this.getAllTodos();
    });
  }
}
