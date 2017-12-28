import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

/* App Root */
import { AppComponent } from './app.component';

/* Feature Modules */
import { SharedModule } from './shared/shared.module';

import { routing } from './app.routing';
import { SidebarComponent, FooterComponent, HeaderComponent } from './components/index';
import { HomeComponent, NotesComponent } from './route/index';


@NgModule({
    imports: [
        BrowserModule,
        routing,
        SharedModule.forRoot()
    ],
    declarations: [
        AppComponent,
        HomeComponent,
        NotesComponent,
        SidebarComponent,
        FooterComponent,
        HeaderComponent
    ],
    bootstrap: [
        AppComponent
    ]
})
export class AppModule { }