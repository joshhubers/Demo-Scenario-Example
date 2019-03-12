import Controller from '@ember/controller';
import EmberArray from '@ember/array';
// import Dinosaur from 'ember-data/types/registries/model';
import { alias } from '@ember/object/computed';
import Dinosaur from 'ember-data/types/registries/model';

export default class DinosaursIndex extends Controller.extend({
  // anything which *must* be merged to prototype here
  dinosaurs: alias('model') as EmberArray<Dinosaur>,
}) {
  // normal class body definition here
}

// DO NOT DELETE: this is how TypeScript knows how to look up your controllers.
declare module '@ember/controller' {
  interface Registry {
    'dinosaurs/index': DinosaursIndex;
  }
}
