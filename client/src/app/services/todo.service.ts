import { Injectable } from '@angular/core';
import { fromEventPattern, Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { State, Todo } from '../models/Todo';
import { PagedObject } from '../models/PagedObject';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class TodoService {

  todosUrl: string = 'http://localhost:5000/api/todos';
  constructor(private http: HttpClient) { }

  getTodos(): Observable<PagedObject> {
    return this.http.get<PagedObject>(this.todosUrl);
  }

  updateTodo(todo: Todo) : Observable<any> {
    const url = `${this.todosUrl}/${todo.id}`;
    return this.http.put<Todo>(url, todo, httpOptions);
  }

  deleteTodo(id: number) : Observable<any> {
    const url = `${this.todosUrl}/${id}`;
    return this.http.delete(url);
  }
}
