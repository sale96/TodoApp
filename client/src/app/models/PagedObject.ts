import { Todo } from './Todo';

export class PagedObject {
     currentPage: number;
     itemsPerPage: number;
     pagesCount: number;
     totalCount: number;
     items: Todo[];
}