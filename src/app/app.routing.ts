import { HomeComponent, NotesComponent } from './route/index';
import { Routes, RouterModule } from '@angular/router';

export const routes: Routes = [    
    { path: "", component: HomeComponent },
    { path: "notes", component: NotesComponent}
];

export const routing = RouterModule.forRoot(routes);