<template>
  <v-container class="sms-composer">
    <v-layout row wrap>
      <v-flex xs12>
        <v-form v-model="valid">
          <v-text-field
            label="Mobile Number"
           ></v-text-field>
          <v-textarea
            label="Sms Content"
          ></v-textarea>
        </v-form>
      </v-flex>
    </v-layout>
  </v-container>
</template>

<script>
export default {
  name: 'SmsComposer',
  data: () => ({
    valid: true
  })
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped lang="stylus">
</style>
