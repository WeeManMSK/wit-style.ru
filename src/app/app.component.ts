import { Component, OnInit, ViewEncapsulation } from "@angular/core";

@Component({
    selector: "app",
    template: require("./app.component.pug"),
    styleUrls: [ "./app.component.scss" ]
})
export class AppComponent implements OnInit {
    
    public constructor() {}
    
    public ngOnInit(): void {}
    
}