import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpErrorResponse} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class HttpRequestService {

  private headers;

  constructor(protected http: HttpClient) {
    this.headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'Accept': 'application/json'
    });
   }

  public get(uri: string, query?, headers?) {
    return this.http.get(uri, {
      headers: this.headers,
      params: query
    })
      .toPromise()
      .then(response => response)
      .catch((err) => this.handleError(err));
  }

  public post(uri, body) {
    return this.http.post(uri, body, {
      headers:this.headers
    })
      .toPromise()
      .then(response => response)
      .catch((err) => this.handleError(err));
  }

  private handleError(error: HttpErrorResponse) {
    return error;
  }
}
