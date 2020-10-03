import { Component, OnInit } from '@angular/core';
import { Todo, State } from '../../models/Todo';

@Component({
  selector: 'app-todos',
  templateUrl: './todos.component.html',
  styleUrls: ['./todos.component.scss']
})
export class TodosComponent implements OnInit {
  todos: Todo[];

  constructor() { }

  ngOnInit(): void {
    this.todos = [
      {
        id: 1,
        name: "Todo 1",
        description: "Description 1234",
        isFinished: false,
        state: State.lowPriority
      },
      {
        id: 2,
        name: "Todo 2",
        description: "Description 1234",
        isFinished: true,
        state: State.mediumPriority
      }
    ];
  }

}
