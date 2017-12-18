import { NgModule } from "@angular/core";
import { AppComponent } from "./app.component";
import { BrowserModule } from "@angular/platform-browser";
import { FormsModule } from "@angular/forms";
import { HttpModule } from "@angular/http";
import { RouteModule } from "./route/route.module";

import { ROUTING } from "./app.routing";


@NgModule({
    imports: [
        BrowserModule,
        FormsModule,
        HttpModule,
        RouteModule,
        ROUTING
    ],
    declarations: [
        AppComponent,
    ],
    bootstrap: [
        AppComponent
    ]
})
export class AppModule {}