import { Component, OnInit } from '@angular/core';
import { RestService } from './rest.service';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent implements OnInit {
  title : string = 'app';
  items : any = null;

  constructor(private _restService: RestService)
 {

  }

  ngOnInit() {
    this._restService.getValues().subscribe(
      response => {this.items = response},
      error => {})
  }
}
