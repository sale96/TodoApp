import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { State, Todo } from '../../models/Todo';
import { TodoService } from '../../services/todo.service';
 
@Component({
  selector: 'app-todo-item',
  templateUrl: './todo-item.component.html',
  styleUrls: ['./todo-item.component.scss']
})
export class TodoItemComponent implements OnInit {
  @Input() todo: Todo;
  @Output() deleteItem: EventEmitter<any> = new EventEmitter();
  @Output() finishItem: EventEmitter<any> = new EventEmitter();

  constructor(private service: TodoService) {
  }

  ngOnInit(): void {
    console.log("Status: " + this.todo.status);
  }

  onDeleteTodo(event) {
    this.deleteItem.emit(this.todo.id);
  }

  onClickFinish(event) {
    this.todo.isFinished = !this.todo.isFinished;
    this.service.updateTodo(this.todo).subscribe(todo => {
      console.log(todo);
    });
  }

  onChangeState(event) {
    const state: State = event.target.options.selectedIndex;
    console.log(state);
    this.todo.status = state;
    this.service.updateTodo(this.todo).subscribe(todo => {
      console.log(todo);
    });
  }
}
