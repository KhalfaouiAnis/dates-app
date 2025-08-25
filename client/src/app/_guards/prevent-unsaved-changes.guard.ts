import { Injectable } from '@angular/core';
import { MemberEditComponent } from '../members/member-edit/member-edit.component';

@Injectable({
  providedIn: 'root',
})
export class PreventUnsavedChangesGuard {
  canDeactivate(component: MemberEditComponent): boolean {
    if (component.editForm?.dirty) {
      return confirm('You have unsaved changes, are you sure to continue ?.');
    }

    return true;
  }
}
