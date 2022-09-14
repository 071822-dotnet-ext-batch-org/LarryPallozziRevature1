import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Time } from '../Models/time';
import { Todo } from '../Models/todo';


@Injectable({
  providedIn: 'root'
})

export class CustomRequestService {

  private ApiUrl = 'https://localhost:7014';
  private JPHURL = "https://jsonplaceholder.typicode.com/todos/1";

  constructor(private http: HttpClient) { }

  public getTime(): Observable<Time> {
    return this.http.get<Time>(this.ApiUrl + "/time");
  }

  public getTodo(): Observable<Todo[]>
  {
    return this.http.get<Todo[]>(this.JPHURL + "/todos");
  }

}
