import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { Todo, State } from '../../models/Todo';

@Component({
  selector: 'app-add-todo',
  templateUrl: './add-todo.component.html',
  styleUrls: ['./add-todo.component.scss']
})
export class AddTodoComponent implements OnInit {
  name: string;
  description: string;
  isFinished: boolean = false;
  status: State = State.lowPriority;

  @Output() todoOutput: EventEmitter<Todo> = new EventEmitter();

  constructor() { }

  ngOnInit(): void {
  }

  addTodo() {
    const todo = new Todo;

    todo.name = this.name;
    todo.description = this.description;
    todo.isFinished = this.isFinished;
    todo.status = this.status;

    this.todoOutput.emit(todo);
  }
}
