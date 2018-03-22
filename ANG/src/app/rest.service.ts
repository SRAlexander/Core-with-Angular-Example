import { Injectable } from "@angular/core";
import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/observable/throw';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/do';

@Injectable()
export class RestService {

  private ApiRoute = "http://localhost:49904/"

  constructor(private _http: HttpClient) {

  }

  //TODO change any to an interface
  getValues(): Observable<any> {
    return this._http.get<any>(this.ApiRoute + "api/Values")
      .do(data => {

      })
      .catch(this.handleError);
  }

  //Todo build on this
  private handleError(err: HttpErrorResponse) {
    console.log(err.message);
    return Observable.throw(err.message);
  }
}

