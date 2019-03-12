import Route from '@ember/routing/route';

export default class DinosaursIndex extends Route.extend({
  // anything which *must* be merged to prototype here
  model() {
    return this.store.findAll('dinosaur');
  }
}) {
  // normal class body definition here
}
