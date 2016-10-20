# ExtraOef

  ```
      private static double BerekenSom(double a, double b)
              {
                  double som = a + b;
                  return a + b;
              }
              private void button_Click(object sender, RoutedEventArgs e)
              {
                  double som = BerekenSom(2.5, 5);
                  textBlock.Text = String.Format("De som is {0}", som);
                  som = BerekenSom(5.5, 2.5);
                  textBlock1.Text = String.Format("De som is {0}", som);
              }
  ```
